using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DownLoadMP3
{
    public class DownLoadHelper
    {
        public static string GetHtml(string url)
        {
            HttpItem item = new HttpItem();
            item.URL = url;
            var client = new HttpHelper();
            var httpResult = client.GetHtml(item);
            return httpResult.Html;
        }

        public static string GetHtmlById(int id)
        {
            var url = $"http://www.170mv.com/song/down/{ id }.html";
            return GetHtml(url);
        }

        public static Music GetMusicById(int id)
        {
            Music m = new Music();
            m.Id = id;

            var html = GetHtmlById(id);
            string namePattern = @"音乐名称：<[^>]+>(?<name>[^<]+)<[^>]+><br\s*/>";
            string albumPattern = @"专辑名称：(?<album>[^<]+)<br\s*/>";
            string singerPattern = @"歌手名称：(?<singer>[^<]+)<br\s*/>";
            string lastUpdatePattern = @"更新日期：(?<lastupdate>[^<]+)<br\s*/>";

            string downloadUrlPattern = @"<a\s*id=""video_down""\s*href=""(?<downloadurl>[^""]+)""[^>]+>";
            string thunderDownloadUrlPattern = @"<a\s*href=""(?<thunderdownloadurl>thunder:[^""]+)""[^>]+>";

            var nameMatch = Regex.Match(html, namePattern);
            m.Name = nameMatch.Groups["name"].Value.Replace("&amp;", "&").Trim();

            var albumMatch = Regex.Match(html, albumPattern);
            m.Album = albumMatch.Groups["album"].Value.Replace("&amp;", "&").Trim();

            var singerMatch = Regex.Match(html, singerPattern);
            m.Singer = singerMatch.Groups["singer"].Value.Replace("&amp;", "&").Trim();

            var lastUpdateMatch = Regex.Match(html, lastUpdatePattern);
            var lastUpdateString = lastUpdateMatch.Groups["lastupdate"].Value.Trim();

            DateTime dateTime;
            if (DateTime.TryParse(lastUpdateString, out dateTime))
            {
                m.LastUpdate = dateTime;
            }

            var downloadUrlMatch = Regex.Match(html, downloadUrlPattern);
            m.DownLoadUrl = downloadUrlMatch.Groups["downloadurl"].Value.Trim();

            var thunderDownloadUrlMatch = Regex.Match(html, thunderDownloadUrlPattern);
            m.ThunderDownLoadUrl = thunderDownloadUrlMatch.Groups["thunderdownloadurl"].Value.Trim();

            return m;

        }

        public static void DownLoadMusic(Music music, string folder)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //string url = "http://antiserver.kuwo.cn/anti.s?rid=MUSIC_71935981&response=res&format=mp3|aac&type=convert_url&br=128kmp3&agent=iPhone&callback=getlink&jpcallback=getlink.mp3";
            var path = folder + "\\" + string.Format("{0}.mp3", music.Name);
            new WebClient().DownloadFile(music.DownLoadUrl, path);
        }
    }
}
