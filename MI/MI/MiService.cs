using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace MI
{
    class MiService: IMiService
    {
        public IList<musicdata> getdata()
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           select new musicdata
                           {
                               Id = music.SONGID.ToString(),//
                               aTitle = music.SONGNAME,//
                               bAuthor = music.MUSICIAN,//
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,//
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS

                           };
                return song.ToList();
            }

        }
        public musicdata[] getall()
        {
            try
            {
                return getdata().ToArray();
            }
            catch (OutOfMemoryException ex)
            {
                fauloutofmemory f = new fauloutofmemory();
                f.lydo = ex.Message;
                throw new FaultException<fauloutofmemory>(f);
            }
        }
        public bool Hasmusic(string music)
        {
            return getdata().Any(x => x.aTitle.ToString().IndexOf(music) != -1);
        }

        public singerdata[] Getsinger(string singid)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var singer = from s in musicct.SINGERs
                             where s.SINGERNAME == singid
                             select new singerdata
                             {
                                 aSingername = s.SINGERNAME,
                                 eSingercom = s.COMPANY,
                                 cSingerday = s.BIRTHDAY.ToString(),
                                 dCountry = s.CITIZENSHIP,
                                 bSingerreal = s.REALNAME,
                                 fSingeravatar = s.AVATAR
                             };
                return singer.ToArray();
            }

        }
        public musicdata[] Getid(string musicid)
        {

            //if (!Hasmusic(musicid.ToString()))
            //{
            //    var error = new CustomFaultMsg { Message = "Không có bài nào với ID là : " + musicid.ToString() };
            //    throw new FaultException<CustomFaultMsg>(error, error.Message);
            //}
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.SONGID.ToString().IndexOf(musicid.ToString()) != -1
                           select new musicdata
                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }
        }
        public musicdata[] Gettitle(string musictitle)
        {
            //if (!Hasmusic(musictitle))
            //{
            //    var error = new CustomFaultMsg { Message = "Không có bài nào là : " + musictitle };
            //    throw new FaultException<CustomFaultMsg>(error, error.Message);
            //}
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.SONGNAME.IndexOf(musictitle) != -1
                           select new musicdata

                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }

        }
        public musicdata[] Getauthor(string author)
        {
            //if (!Hasmusic(author))
            //{
            //    var error = new CustomFaultMsg { Message = "Không có bài nào author là : " + author };
            //    throw new FaultException<CustomFaultMsg>(error, error.Message);
            //}
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.MUSICIAN.IndexOf(author) != -1
                           select new musicdata

                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }

        }
        public musicdata[] Getlang(string lang)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.LANGUAGE == lang
                           select new musicdata

                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }
        }
        public musicdata[] Getlyric(string lyric)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.LYRICS.IndexOf(lyric) != -1
                           select new musicdata

                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }
        }
        public musicdata[] Getkaraoke(string karaoke)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.KARAOKE.ToString().IndexOf(karaoke) != -1
                           select new musicdata

                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }
        }
        public string Getemotion(string emotion)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.EMOTION.EMOTIONTYPE.ToString() == emotion
                           select new
                           {
                               Emotion = music.EMOTION.DESCRIPTION
                           };
                return song.First().ToString();
            }
        }
        public musicdata[] Getgenre(string genre)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.CATEGORY.ToString().IndexOf(genre) != -1
                           select new musicdata

                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }
        }
        public musicdata[] Getpub(string pub)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where DateTime.Parse(music.PUBLISH.ToString()).Year.ToString() == pub
                           select new musicdata

                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }
        }

        public musicdata[] gettop()
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs

                           orderby music.VOTE descending

                           select new musicdata
                           {
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               cSinger = music.SINGER.SINGERNAME,
                               Lyric = music.LYRICS,
                               avatar = music.SINGER.AVATAR,
                               vote= music.VOTE.ToString()
                           };
                return song.Take(10).ToList().ToArray();
            }
        }
        public musicdata[] Getins(string ins)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.INSTRUMENT.IndexOf(ins) != -1
                           select new musicdata

                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }
        }


        // Xay Dung Ham Tim Kiem
        public musicdata[] musickaraoke(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.KARAOKE.ToString().IndexOf(timtheo) != -1 & music.CATEGORY.IndexOf(loctheo) != -1
                           & music.PUBLISH.IndexOf(thoigian) != -1
                           & music.LANGUAGE.IndexOf(quocgia) != -1
                           & music.EMOTION.EMOTIONTYPE.IndexOf(tamtrang) != -1
                           select new musicdata
                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }

        }

        public musicdata[] musicnhacsi(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.MUSICIAN.IndexOf(timtheo) != -1 & music.CATEGORY.IndexOf(loctheo) != -1
                           & music.PUBLISH.IndexOf(thoigian) != -1
                           & music.LANGUAGE.IndexOf(quocgia) != -1
                           & music.EMOTION.EMOTIONTYPE.IndexOf(tamtrang) != -1
                           select new musicdata
                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }

        }

        public musicdata[] musiccasi(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.SINGER.SINGERNAME.IndexOf(timtheo) != -1 & music.CATEGORY.IndexOf(loctheo) != -1
                           & music.PUBLISH.IndexOf(thoigian) != -1
                           & music.LANGUAGE.IndexOf(quocgia) != -1
                           & music.EMOTION.EMOTIONTYPE.IndexOf(tamtrang) != -1
                           select new musicdata
                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }

        }

        public musicdata[] musicloi(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.LYRICS.IndexOf(timtheo) != -1 & music.CATEGORY.IndexOf(loctheo) != -1
                           & music.PUBLISH.IndexOf(thoigian) != -1
                           & music.LANGUAGE.IndexOf(quocgia) != -1
                           & music.EMOTION.EMOTIONTYPE.IndexOf(tamtrang) != -1
                           select new musicdata
                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }

        }

        public musicdata[] musicten(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang)
        {
            using (var musicct = new DataClassesDataContext())
            {
                var song = from music in musicct.SONGs
                           where music.SONGNAME.IndexOf(timtheo) != -1 & music.CATEGORY.IndexOf(loctheo) != -1
                           & music.PUBLISH.IndexOf(thoigian) != -1
                           & music.LANGUAGE.IndexOf(quocgia) != -1
                           & music.EMOTION.EMOTIONTYPE.IndexOf(tamtrang) != -1
                           select new musicdata
                           {
                               Id = music.SONGID.ToString(),
                               aTitle = music.SONGNAME,
                               bAuthor = music.MUSICIAN,
                               Lang = music.LANGUAGE,
                               cSinger = music.SINGER.SINGERNAME,
                               eGenre = music.CATEGORY,
                               dPublish = music.PUBLISH.ToString(),
                               Karaoke = music.KARAOKE.ToString(),
                               Emotion = music.EMOTION.EMOTIONTYPE,
                               Instrument = music.INSTRUMENT,
                               Lyric = music.LYRICS
                           };
                return song.ToList().ToArray();
            }

        }

        public void setvote(int musicid, int vote)
        {
            using (var musicct = new DataClassesDataContext())
            {
                SONG song = musicct.SONGs.Single(p => p.SONGID == musicid);
                song.VOTE += vote;

                musicct.SubmitChanges();
            }

        }

        public decimal getvote(int musicid)
        {
            decimal? a;
            using (var musicct = new DataClassesDataContext())
            {
                SONG song = musicct.SONGs.Single(p => p.SONGID == musicid);
                a = song.VOTE;

            }
            return decimal.Parse(a.ToString());

        }

        public void Addmusic(musicdata music)
        {
            getdata().Add(music);
        }


        public void Editmusic(int musicid, musicdata music)
        {
        }

        public void Deletemusic(int musicid)
        {
        }
    }
}
