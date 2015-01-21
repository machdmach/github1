using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAudio.Ext
{
    public class Mp3Split
    {
        public static void Test1()
        {
            var mp3Path = @"C:\Temp2\WordmasterDisk9.mp3";
            int splitLength = 120; // seconds

            var mp3Dir = Path.GetDirectoryName(mp3Path);
            var mp3File = Path.GetFileName(mp3Path);
            var splitDir = Path.Combine(mp3Dir, Path.GetFileNameWithoutExtension(mp3Path));
            Directory.CreateDirectory(splitDir);

            int splitI = 0;
            int secsOffset = 0;

            using (var reader = new Mp3FileReader(mp3Path))
            {
                FileStream writer = null;
                Action createWriter = new Action(() =>
                {
                    string newFnameExt = (++splitI).ToString("D4") + ".mp3";
                    string newFname = Path.ChangeExtension(mp3File, newFnameExt);

                    string newPfname = Path.Combine(splitDir, newFname);
                    writer = File.Create(newPfname);
                });

                Mp3Frame frame;
                while ((frame = reader.ReadNextFrame()) != null)
                {
                    if (writer == null) createWriter();

                    if ((int)reader.CurrentTime.TotalSeconds - secsOffset >= splitLength)
                    {
                        // time for a new file
                        writer.Dispose();
                        createWriter();
                        secsOffset = (int)reader.CurrentTime.TotalSeconds;
                    }

                    writer.Write(frame.RawData, 0, frame.RawData.Length);
                }

                if (writer != null) writer.Dispose();
            }
        }
    }
}
