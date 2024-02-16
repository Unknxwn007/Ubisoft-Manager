# GMUI
GMUI stands for "Give Me Uncompressed Images", it's only purpose is to remove duplicate images from game clients like Ubisoft Connect and only keep the uncompressed images.

## Why?
By default the screenshots are compressed, turning on the option to save an uncompressed copy of the image gives you a higher quality screenshot however, it still stores the compressed image which you may not want, hence the script.

## Goals
- Add support for steam

## How does it work?
It simply goes through the folder you selected in the config file (This better be the folder you save the screenshots to.) and removes the images with a .jpg extension. 