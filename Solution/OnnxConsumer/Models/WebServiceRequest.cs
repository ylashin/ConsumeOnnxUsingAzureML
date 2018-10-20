using System.Collections.Generic;

namespace OnnxConsumer.Models
{
    public class WebServiceRequest
    {
        // List of sample input images, in our case one image in every request
        // Every image has 3 color channels
        // Every color channel has list of rows 
        // Every row has a list of columns and this is the final dimension that has pixel values

        public List<List<List<List<int>>>> data { get; set; }
    }

}
