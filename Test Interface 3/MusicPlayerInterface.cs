using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    interface MusicPlayerInterface
    {
        void switchs(bool on);
        void play(bool on);
        void setVolume(int loudness);
        void playNext();
        void playPrevious();
    } 
}
