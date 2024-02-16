import json
import pathlib

with open('config.json') as f:
    config = json.load(f)

ubi_dir = pathlib.Path(config['directories']['ubi_directory'])

unicode_tm = '\u2122'
unicode_reg = '\u00AE'
ubi_dir_unescaped = ubi_dir.with_name(ubi_dir.name.replace('™️', unicode_tm).replace('®', unicode_reg))

subdirectories = [p for p in ubi_dir_unescaped.glob('*') if p.is_dir()]

for subdir in subdirectories:
    subdir_unescaped = subdir.with_name(subdir.name.replace('™️', unicode_tm).replace('®', unicode_reg))

    for filename in subdir.glob('*.jpg'):
        try:
            filename.unlink()
        except OSError as e:
            print(f"Error deleting file {filename}: {e.strerror}")
print(f"Done! All compressed images removed, enjoy your high quality screenshots!")