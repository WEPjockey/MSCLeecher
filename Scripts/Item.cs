﻿
namespace Leecher.Scripts
{
    public class Item
    {    
        public string Info { set; get; }
        public string Link { set; get; }
        public override string ToString()
        {
            return Info + "\n   " + Link;
        }

    }
    enum Mod
    {
        Cookies,
        Account
    }
    enum PageTypes
    {
        TVShow,
        TVShowDownloadPage,
        Movie,
        MovieDownloadPage,
        Series,
        SeriesDownloadPage,
        Unkown
    }
}
