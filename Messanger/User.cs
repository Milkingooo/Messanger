using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    class User
    {
        private int id;
        private string name;
        private string image;
        private string loadedImage;

        public User(int id, string name, string image)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.loadedImage = "";
        }

        public void LoadImage()
        {

        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Image
        {
            get
            {
                if (string.IsNullOrEmpty(this.loadedImage))
                {
                    return this.image;
                }
                else
                {
                    return this.loadedImage;
                }
            }
        }
    }
}
