import json
import pathlib
import os
import keyboard

with open('config.json') as f:
    config = json.load(f)

ubi_dir = pathlib.Path(config['directories']['ubi_directory'])
steam_dir = pathlib.Path(config['directories']['steam_directory'])

unicode_tm = '\u2122'
unicode_reg = '\u00AE'

def unescape_path(path):
    """Unescape path by replacing Unicode characters"""
    return path.with_name(path.name.replace('™️', unicode_tm).replace('®', unicode_reg))

ubi_dir_unescaped = unescape_path(ubi_dir)
steam_dir_unescaped = unescape_path(steam_dir)

def delete_images(directory):
    """Delete all.jpg files in the given directory"""
    num_deleted_images = 0
    for filename in directory.glob('*.jpg'):
        if filename.exists():
            try:
                filename.unlink()
                num_deleted_images += 1
            except OSError as e:
                print(f"Error deleting file {filename}: {e.strerror}")
    return num_deleted_images

def remove_duplicates(directory):
    """Remove duplicate images in the given directory, keeping only the ones with _1 suffix"""
    files = [f for f in directory.glob('*.jpg')]
    file_names = [f.stem for f in files]
    duplicates = [f for f in file_names if file_names.count(f) > 1]
    num_deleted_images = 0
    for duplicate in duplicates:
        files_to_delete = [f for f in files if f.stem == duplicate and not f.name.endswith('_1.jpg')]
        for file in files_to_delete:
            try:
                file.unlink()
                num_deleted_images += 1
            except OSError as e:
                print(f"Error deleting file {file}: {e.strerror}")
    return num_deleted_images

print("Press 1 to delete Ubisoft images, 2 to delete Steam images, or 3 to delete both:")
while True:
    key = keyboard.read_key()
    if key == '1':
        num_deleted_images = delete_images(ubi_dir_unescaped)
        remove_duplicates(ubi_dir_unescaped)
        break
    elif key == '2':
        num_deleted_images = delete_images(steam_dir_unescaped)
        remove_duplicates(steam_dir_unescaped)
        break
    elif key == '3':
        num_deleted_images = delete_images(ubi_dir_unescaped) + delete_images(steam_dir_unescaped)
        remove_duplicates(ubi_dir_unescaped)
        remove_duplicates(steam_dir_unescaped)
        break
    else:
        print("Invalid input. Please press 1, 2, or 3.")

if num_deleted_images == 0:
    print("\033[91m" + "No compressed images found!" + "\033[0m")
else:
    print(f"Done! {num_deleted_images} compressed images removed, enjoy your high quality screenshots!")