using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObjects;

namespace WinForms.Helpers
{
    public static class AdminData
    {
        public static DataTransferObjects.Administrator _admin; 
        private static PictureBox _photo;
        private static Label _imePrezime;


        public static void SetObjects(PictureBox photo, Label imePrezime)
        {
            _photo = photo;
            _imePrezime = imePrezime;
        }

        public static void Set(DataTransferObjects.Administrator newAdmin)
        {
            _admin = newAdmin;

            _imePrezime.Text = $"{_admin.Ime} {_admin.Prezime}";

            if (_admin.Slika.Length != 0)
                _photo.Image = Converters.ByteArrayToSystemDrawing(_admin.Slika);
        }

        public static DataTransferObjects.Administrator Get()
        {
            return _admin;
        }
    }
}
