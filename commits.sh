#/bin/bash
git add ./*
echo input the commit message

read message
git commit -m \"message\"
git push -u origin master
