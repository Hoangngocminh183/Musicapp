Business_Social_Network_Flutter_App
Clean-Code convention
In this project we use Pascal and Camel naming convention for variable name and function name
Access Modifiers must be clearly
Describe everything easy to confuse, cross class function & variables, dependences, helpers in comment clearly in English
Add comma ',' after every parameter
Git rules
Must not push code to branch master/main, push and create pull request from branch feature to branch develop.
Commit and push code to github from 7 A.M to 11 P.M, pull request after this time will be checked in next day.
Fetch code before coding new feature.
Each feature create a brand new branch.
Must not merge code.
Git & Working flow
Step 1: Clone Project
git clone http://

if any error occur, try:

git clone https://

image

Step 2: Check local Git branch & remote Git branch.
git branch -a

image

Step 3: Fetch code from remote to local before working.
git fetch origin develop

image

Step 4: Checkout to develop branch.
git checkout develop

image

[IMPORTANT] From this, every push and create pull request event will be pushed only to branch develop, must not work with master/main branch (this branch will store lasted stable state of project).

Step 5: Checkout from branch develop to branch feature to working with your feature.
[IMPORTANT] Every push and create pull request event will be pushed only to branch develop, must not work with master/main branch (this branch will store lasted stable state of project).

git checkout -b feature/tasks_name

Step 6: [IMPORTANT] When everything have done, check status, test every parts of project from beginning flow of application.
git status

image

Step 7: Affter testing, add all files have change and commit.
git add .

git commit -m 'What are added, changed, removed, name of feature'

NOTICE [What are added, changed, removed, name of feature] must writen in English clearly and detail. image

Step 8: Push from local to remote
git push origin [Name of branch that you are working]

if you just clone project, try:

git --set-upstream origin [Name of branch that you are working]

this command will set up a tracking relationship between local and remote repo

image

Step 9: Access Github.com and create pull request
Step 10: Check branch have pushed or not. If anything go wrong you can't not see your branch as remote branch
git branch -a

Step 11: Before want to begin new section, ask Duong Tung check everything before update code
git fetch --prune

Check all branch again

git branch -a

If you see branch feature/name_of_your_branch is deleted, your code is accepted and merged to Develop. If anything wrong with that code you will receive email with comments.

Step 12:Checkout Develop, pull newest code and repeat the process
git checkout develop

git pull
