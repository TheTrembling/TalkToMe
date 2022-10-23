using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TalkToMe
{
    public class Image
    {
        public Image()
        {

        }
        public Image(int id, string filename, string title, byte[] data)
        {
            Id = id;
            FileName = filename;
            Title = title;
            Data = data;
        }
        public int Id { get; private set; }
        public string FileName { get; private set; }
        public string Title { get; private set; }
        public byte[] Data { get; private set; }

        public string LoadImage(string lgn1, string lgn2)
        {
            string photoName = "";
            using (TalkToMeEntities db = new TalkToMeEntities())
            {
                List<Image> images = new List<Image>();
                var au = db.Photos.ToList();
                foreach (var a in au)
                {
                    if (lgn1 == a.Login)
                    {
                        int _id = a.Id;
                        string _filename = a.FileName;
                        string _title = a.Login;
                        byte[] _data = (byte[])a.ImageData;

                        Image image = new Image(_id, _filename, _title, _data);
                        images.Add(image);
                        break;
                    }
                }
                if (images.Count > 0)
                {
                    photoName = $"{lgn2}/Photos/{images[0].FileName}";

                    DirectoryInfo di = new DirectoryInfo($"{lgn2}/Photos");
                    if (!di.Exists)
                        di.Create();

                    FileInfo fi = new FileInfo(photoName);

                    if (!fi.Exists)
                    {
                        using (FileStream fs = new FileStream(photoName, FileMode.OpenOrCreate))
                        {
                            fs.Write(images[0].Data, 0, images[0].Data.Length);
                        }
                    }
                }
                return photoName;
            }
        }

    }
}
