#######                                                                     #######
#    _               _                 __              _     _                    #
#   | |__   __ _ ___| |__  _ __ ___   / _| ___  _ __  | |   (_)_ __  _   ___  __  #
#   | '_ \ / _` / __| '_ \| '__/ __| | |_ / _ \| '__| | |   | | '_ \| | | \ \/ /  #
#  _| |_) | (_| \__ \ | | | | | (__  |  _| (_) | |    | |___| | | | | |_| |>  <   #
# (_)_.__/ \__,_|___/_| |_|_|  \___| |_|  \___/|_|    |_____|_|_| |_|\__,_/_/\_\  #
#                                                                                 #
######                                                                      #######

# for setting history length see HISTSIZE and HISTFILESIZE in bash(1)
HISTSIZE=1000
HISTFILESIZE=2000

# for PS1 settings
if [ "$color_prompt" = yes ]; then
    PS1='${debian_chroot:+($debian_chroot)}\[\033[01;32m\]\u@\h\[\033[00m\]:[\[\033[01;33m\]\w\[\033[00m\]]\n\[\033[31m\]$(__git_ps1)\[\033[00m\]\$:'
else
    PS1='${debian_chroot:+($debian_chroot)}\[\033[01;32m\]\u@\h\[\033[00m\]:[\[\033[01;33m\]\w\[\033[00m\]]\n\[\033[31m\]$(__git_ps1)\[\033[00m\]\$:'
fi

source /etc/bash_completion.d/git-prompt
source /usr/share/bash-completion/completions/git

GIT_PS1_SHOWDIRTYSTATE=true
GIT_PS1_SHOWUNTRACKEDFILES=true
GIT_PS1_SHOWSTASHSTATE=true
GIT_PS1_SHOWUPSTREAM=auto
