# Unity 3D Game - for [GitHub game off jam 25](https://itch.io/jam/game-off-2025)

## Current state of game 
1. Tested could build web version of unity game and [host on itch.io](https://willhebe.itch.io/unity-test-waves-github-game-off-25)
2. Rows of test cylinders are instantiated as prefabs when user presses right mouse button. 
3. No movement as yet. - tested using main camera rotating around y-axis and couls see more of the cylinders

## Editing instructions
1. Install Unity Hub
2. Using unity Hub : Install Unity 6000.2.10f1

### Note
You may need git LFS (Large File Storage) at [git lfs](https://git-lfs.com/)  to do this because of how I set up the GitHub repository to use this

### Using git in Windows
3. Create folder you wish to work in
4. Navigate to folder in File Manager and right click -> open Git Bash here (I have to show more options to get to this)
5. ```
      git clone https://github.com/Willhebe/UnityGitHubGameJam25.git
   ```
6. go to folder in file manager and open UnityGitHubGameJam25 - .git files should be there.
7. open git bash again in this folder.
8. Switch branch to dev branch to get latest updates.
   ```
      git switch dev
   ``` 


### back to unity hub
9. Projects -> Add -> Add project from disk
![Screenshot](https://github.com/Willhebe/UnityGitHubGameJam25/blob/0f3a951a857e51fd7299ac90c3a639c845b156d4/Screenshot%202025-11-02%20211220.png)
10. Navigate to folder where you put the clone and then open folder : UnityGitHubGameJam25
11. Press Open
12. Open the project - takes about 5 -10 minutes to rebuild the libraries and open project on my slow machine
13. edit.

### to push files back to github
1. Once edited ensure assets are saved and close Unity editor so as not to interfere with git 
2. Check to see if files need updating
   ```
       git status
   ```
   should be tracking origin/dev if didn't change git after open for editing
3.
   ```
      git add .
   ```
4. ```
      git commit -m "commmit message"
   ```
5. ```
      git push origin dev
   ```
    
