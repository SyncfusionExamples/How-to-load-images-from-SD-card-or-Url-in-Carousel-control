using System;
using System.Collections.Generic;
using System.Text;

namespace SfCarouselImageLoading
{
    public class SDCarouselViewModel
    {
        public SDCarouselViewModel()
        {
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Pictures/download1.JPG"));
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Pictures/download2.JPG"));
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Pictures/download3.JPG"));
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Pictures/download4.JPG"));
            ImageCollection.Add(new CarouselModel("/storage/emulated/0/Pictures/download5.JPG"));


        }

        private List<CarouselModel> _imageCollection = new List<CarouselModel>();

        public List<CarouselModel> ImageCollection
        {
            get { return _imageCollection; }
            set { _imageCollection = value; }
        }
    }
}
