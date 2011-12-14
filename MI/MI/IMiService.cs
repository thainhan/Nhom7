using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace MI
{
    using System.Runtime.Serialization;
    using System.ServiceModel;
    [DataContract]
    public class musicdata
    {
        [DataMember]
        public string    Id;

        [DataMember]
        public string aTitle;
        
        [DataMember]
        public string Lang;
        
        [DataMember]
        public string cSinger;
        
        [DataMember]
        public string bAuthor;

        [DataMember]
        public string Lyric;
        
        [DataMember]
        public string eGenre;
        
        [DataMember]
        public string dPublish;
        
        [DataMember]
        public string Karaoke;
        
        [DataMember]
        public string Emotion;
        
        [DataMember]
        public string Instrument;

        [DataMember]
        public string vote;

        [DataMember]
        public string avatar;
    }

    [DataContract]
    public class singerdata
    {
        [DataMember]
        public string dCountry;
        [DataMember]
        public string aSingername;
        [DataMember]
        public string bSingerreal;
        [DataMember]
        public string cSingerday;
        [DataMember]
        public string eSingercom;
        [DataMember]
        public string fSingeravatar;

    }
    
    
    [DataContract]
    public class fauloutofmemory
    {
        [DataMember]
        public string lydo { get; set; }
    }
    
    [ServiceContract]
    public interface IMiService
    {
        [OperationContract]
        [FaultContract(typeof(fauloutofmemory))]
        musicdata[] getall();

        [OperationContract]
        bool Hasmusic(string music);


        [OperationContract]
        musicdata[] Getid(string music);

        [OperationContract]
        musicdata[] Gettitle(string title);

        [OperationContract]
        musicdata[] Getauthor(string author);

        [OperationContract]
        musicdata[] Getlyric(string lyric);

        [OperationContract]
        musicdata[] Getgenre(string genre);

        [OperationContract]
        string Getemotion(string emotion);

        [OperationContract]
        musicdata[] Getins(string ins);

        [OperationContract]
        musicdata[] Getpub(string pub);

        [OperationContract]
        musicdata[] Getkaraoke(string karaoke);

        [OperationContract]
        musicdata[] Getlang(string lang);

        [OperationContract]
        musicdata[] musickaraoke(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang);

        [OperationContract]
        musicdata[] musicnhacsi(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang);

        [OperationContract]
        musicdata[] musiccasi(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang);

        [OperationContract]
        musicdata[] musicloi(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang);

        [OperationContract]
        musicdata[] musicten(string timtheo, string loctheo, string thoigian, string quocgia, string tamtrang);

        [OperationContract]
        singerdata[] Getsinger(string singerid);

        [OperationContract]
        musicdata[] gettop();

        [OperationContract]
        void setvote(int musicid, int vote);

        [OperationContract]
        decimal getvote(int musicid);

        [OperationContract]
        void Addmusic(musicdata music);


        [OperationContract]
        [FaultContract(typeof(CustomFaultMsg))]
        void Editmusic(int musicid, musicdata music);


        [OperationContract]
        [FaultContract(typeof(CustomFaultMsg))]
        void Deletemusic(int musicid);
    }
    
}
