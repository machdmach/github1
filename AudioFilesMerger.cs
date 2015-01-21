using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAudio.Ext
{
    public class AudioFilesMerger
    {
        public static void Test1()
        {
            String rootInputDir = @"H:\English\WordMaster_DenisWaitley";
            //String inputDir = @"C:\temp2\Word master Disk 9";
            String[] dirs = Directory.GetDirectories(rootInputDir);
            foreach (string inputDir in dirs)
            {                
                Combine(inputDir);
            }
        }

        public static void Combine(String inputDir)
        {
            String[] files = Directory.GetFiles(inputDir, "*.mp3");
            //string dirName = Path.GetDirectoryName(inputDir);
            string dirName_lastPart = Path.GetFileName(inputDir);
            string outputFilename = dirName_lastPart.Replace(" ", "");
            outputFilename += ".mp3";

            //string outputPfname = @"C:\temp\combined.mp3";
            string outputPfname = Path.Combine(Path.GetDirectoryName(inputDir), outputFilename);

            Console.WriteLine("Reading files from dir: " + inputDir);
            Console.WriteLine("Writing combined file to: "+ outputPfname);
            //return;

            File.Delete(outputPfname);

            using (FileStream fs = new FileStream(outputPfname, FileMode.CreateNew))
            {
                Combine(files, fs);
            }
        }


        public static void Combine(string[] inputFiles, Stream output)
        {
            foreach (string file in inputFiles)
            {
                using (Mp3FileReader reader = new Mp3FileReader(file))
                {
                    if ((output.Position == 0) && (reader.Id3v2Tag != null))
                    {
                        output.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);
                    }
                    Mp3Frame frame;
                    while ((frame = reader.ReadNextFrame()) != null)
                    {
                        output.Write(frame.RawData, 0, frame.RawData.Length);
                    }
                }
            }
        }
    }
}
