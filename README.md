# MMCPrivate
MMCPrivate

$ gdcmraw -t 0029,102f hitachi.dcm sample.raw

possibly:

dd bs=1 skip=1 sample.raw fixed.raw

On UNIX:

First:
% mono-csc ApplicationObjects.cs

then

% mono-csc Dump.cs

./Dump.exe

Or:

% mono-csc ApplicationObjects.cs AssemblyInfo.cs

And then compare output
