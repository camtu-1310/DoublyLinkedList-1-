using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnKTHP
{
    class Book
    {
        private string id;
        private string tieude;
        private string tacgia;
        private float gia;
        private string nhaxuatban;
        private float namxuatban;

        public string getId()
        {
            return id;
        }

        public string getTieude()
        {
            return tieude;
        }

        public string getTacgia()
        {
            return tacgia;
        }

        public float getGia()
        {
            return gia;
        }
        public string getNhaxuatban()
        {
            return nhaxuatban;
        }
        public float getNamxuatban()
        {
            return namxuatban;
        }

        public Book(string id, string tieude, string tacgia, float gia, string nhaxuatban, float namxuatban)
        {
            this.id = id;
            this.tieude = tieude;
            this.tacgia = tacgia;
            this.gia = gia;
            this.nhaxuatban = nhaxuatban;
            this.namxuatban = namxuatban;
        }

        override public string ToString()
        {
            return "Book(" + id + ", " + tieude + "," + tacgia + " , " + gia + ", " + nhaxuatban + ", " + namxuatban + ")";
        }
    }
}
