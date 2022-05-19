using System;
using System.Collections.Generic;
using System.Text;

namespace SfCarouselImageLoading
{
    public class URLCarouselViewModel
    {
        public URLCarouselViewModel()
        {
            ImageCollection.Add(new CarouselModel("https://cdn.syncfusion.com/content/images/Images/Camtasia_Succinctly.png?v=22022017060923"));
            ImageCollection.Add(new CarouselModel("https://cdn.syncfusion.com/content/images/Images/SQL_Queries_Succinctly.png?v=04022017014551"));
            ImageCollection.Add(new CarouselModel("https://cdn.syncfusion.com/content/images/Images/Keystonejs_Succinctly.png?v=22022017060923"));
            ImageCollection.Add(new CarouselModel("https://cdn.syncfusion.com/content/images/Images/sql_server_for_c_sharp_developers_succinctly_cover_img.png?v=22022017060923"));
            ImageCollection.Add(new CarouselModel("https://cdn.syncfusion.com/content/images/downloads/ebooks/SciPy_Programming_Succinctly_img.png?v=22022017060923"));


        }

        private List<CarouselModel> _imageCollection = new List<CarouselModel>();

        public List<CarouselModel> ImageCollection
        {
            get { return _imageCollection; }
            set { _imageCollection = value; }
        }

    }
}
