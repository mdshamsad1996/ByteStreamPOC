##### ByteStreamPOC

Reading any kind of file Byte wise and write it into same type of file


Here I am reading every 1000 bytes of mp3 file and writing it to another mp3.file

##### Purpose:
       Suppose we have an video file of size 10 Gb and want it read it and write to another location using programming.
       If we Read complete Video once and our RAM is 2GB then our System will be Stuck because we want to load 10GB file in 2 GB Memory.
       To accomplish this task we can use ByteStream to Read a file and write into a file with Fixed Size like we can read 1Gb fixed size          file 10 times using loop.
