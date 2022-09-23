MMCPrivate
---

gdcmraw -t 0009,1003 input.dcm 1003.raw
gdcmraw -t 0009,1050 input.dcm 1050.raw
gdcmraw -t 0019,1021 input.dcm 1021.raw
gdcmraw -t 0029,102f input.dcm 102f.raw
gdcmraw -t 0029,10d7 input.dcm 10d7.raw


./ConsoleApp/bin/Debug/net5.0/ConsoleApp.exe 1003.raw gen.1003.raw
...

Compare nrb or json as you like

.vimrc:
autocmd BufReadPost *.nrb silent %!netfleece -x -p -i "%"
