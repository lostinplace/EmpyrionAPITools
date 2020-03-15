import vdf
import winreg

DEDI_SERVER_APPID = '530870'
EGS_APPID = '383120'
EMPYRION_DLL_FOLDER_PATH = 'DedicatedServer/EmpyrionDedicated_Data/Managed'
EMPYRION_MOD_FOLDER_PATH =  'Content/Mods'

DLLS_BEING_COPIED = [
    'Mif.dll',
    'ModApi.dll',
    'UnityEngine.CoreModule.dll'
]


def get_steam_install_path():
    from winreg import ConnectRegistry, HKEY_LOCAL_MACHINE, OpenKeyEx, QueryValueEx, REG_EXPAND_SZ, REG_SZ
    root = ConnectRegistry(None, HKEY_LOCAL_MACHINE)
    steam_software_key = OpenKeyEx(root, r"SOFTWARE\Wow6432Node\Valve\Steam")
    install_path, type_ = QueryValueEx(steam_software_key, "InstallPath")
    return install_path


def get_library_folders(install_path: str):
    from os import path
    steamapps_folder_location = path.join(install_path, 'steamapps')
    steamapps_location = path.join(steamapps_folder_location, 'libraryfolders.vdf')
    with open(steamapps_location) as libraryfolders_stream:
        libraries_manifest = vdf.load(libraryfolders_stream)

    numeric_keys = [i for i in libraries_manifest.keys() if i.isnumeric()]
    other_paths = [libraries_manifest[i] for i in numeric_keys]

    result = [steamapps_folder_location]
    result += other_paths

    return result


def find_folder_with_app_manifest(library_folders, appid):
    from os import path
    looking_for_file = f'appmanifest_{appid}.acf'

    for a_path in library_folders:
        candidate_path = path.join(a_path, looking_for_file)
        if path.exists(candidate_path):
            return candidate_path

    return None


def get_empyrion_install_path(library_folders, appid):
    from os import path
    import vdf

    looking_for_file = f'appmanifest_{appid}.acf'

    candidate_path = find_folder_with_app_manifest(library_folders, appid)

    if not candidate_path:
        raise Exception(f"Empyrion with AppID {appid} was not found on this system's Steam installation")

    with open(candidate_path) as appmanifest_stream:
        appmanifest = vdf.load(appmanifest_stream)

    installdir = appmanifest['AppState']['installdir']
    base_folder = path.dirname(candidate_path)

    return path.join(base_folder, 'common', installdir)


def copy_dlls(source_folder, target_folder):
    from os import path
    from shutil import copy

    for dll in DLLS_BEING_COPIED:
        source_path = path.join(source_folder, dll)
        print(f"copying {dll} to {target_folder}")
        copy(source_path, target_folder)

    print("dll copy complete")


def copy_mod_contents(src_folder, mod_name, empyrion_installation_folder):
    from shutil import copytree, rmtree
    from os import path

    mods_folder_path = path.join(empyrion_installation_folder, EMPYRION_MOD_FOLDER_PATH, mod_name)

    if path.exists(mods_folder_path):
        print(f"removing existing tree at {mods_folder_path}")
        rmtree(mods_folder_path)
        print("old mod removed")

    print(f"copying the tree at {src_folder} to {mods_folder_path}")
    copytree(src_folder, mods_folder_path)
    print("deploy complete")


def main(args):
    from os import path

    install_path = get_steam_install_path()
    library_folders = get_library_folders(install_path)
    empyrion_install_path = get_empyrion_install_path(library_folders, DEDI_SERVER_APPID)

    if args.copyDllsToFolder:
        installed_dlls_folder = path.join(empyrion_install_path, EMPYRION_DLL_FOLDER_PATH)
        copy_dlls(installed_dlls_folder, args.copyDllsToFolder)

    if args.bundleAndDeployMod:
        copy_mod_contents(args.bundleAndDeployMod, args.modName, empyrion_install_path)


def construct_arg_parser():
    import argparse

    parser = argparse.ArgumentParser(
        description='scripts to help build and deploy empyrion mods',
        epilog='Note: modname must be specified when using the bundleAndDeployMod option'
    )

    parser.add_argument("--copyDllsToFolder", help="the folder to copied the required dlls to")
    parser.add_argument("--modName", help="the name of the mod being deployed")
    parser.add_argument("--bundleAndDeployMod", help="the folder containing the mod that will be deployed")

    def result_parser():
        result = parser.parse_args()
        if result.bundleAndDeployMod and not result.modName:
            parser.error('you must specify a modname when using the bundleAndDeployMod option')
        return result

    return result_parser


if __name__ == '__main__':
   parser = construct_arg_parser()
   args = parser()
   main(args)
