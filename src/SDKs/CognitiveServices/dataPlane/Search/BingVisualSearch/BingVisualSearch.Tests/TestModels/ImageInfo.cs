// -----------------------------------------------------------------------
// <copyright file="ImageInfo.cs" company="Microsoft">
//  Copyright (c) Microsoft. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Azure.CognitiveServices.Search.VisualSearch.TestModels
{
    using Newtonsoft.Json;

    public partial class ImageInfo
    {
        /// <summary>
        /// Initializes a new instance of the ImageInfo class.
        /// </summary>
        public ImageInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageInfo class.
        /// </summary>
        /// <param name="imageInsightsToken">An image insights token. To 
        /// get the insights token, call one of the Image Search APIs (for 
        /// example, /images/search). In the search results, the 
        /// [Image](https://docs.microsoft.com/en-us/rest/api/cognitiveservices/bing-images-api-v7-reference#image) 
        /// object's [imageInsightsToken](https://docs.microsoft.com/en-us/rest/api/cognitiveservices/bing-images-api-v7-reference#image-imageinsightstoken) 
        /// field contains the token. The image binary and imageInsightsToken 
        /// fields are mutually exclusive � do not specify both.</param>
        /// <param name="url">The URL of the input image. The URL should 
        /// match the image specified by the imageInsightsToken fields if 
        /// both are present. The image binary and URL fields are mutually 
        /// exclusive � do not specify both.</param>
        /// <param name="cropArea">A JSON object consisting of coordinates 
        /// specifying the four corners of a cropped rectangle within the 
        /// input image.</param>
        public ImageInfo(string imageInsightsToken = default(string), string url = default(string), CropArea cropArea = default(CropArea))
        {
            ImageInsightsToken = imageInsightsToken;
            Url = url;
            CropArea = cropArea;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// An image insights token. To 
        /// get the insights token, call one of the Image Search APIs (for 
        /// example, /images/search). In the search results, the 
        /// [Image](https://docs.microsoft.com/en-us/rest/api/cognitiveservices/bing-images-api-v7-reference#image) 
        /// object's [imageInsightsToken](https://docs.microsoft.com/en-us/rest/api/cognitiveservices/bing-images-api-v7-reference#image-imageinsightstoken) 
        /// field contains the token. The image and imageInsightsToken 
        /// fields are mutually exclusive � do not specify both.
        /// </summary>
        [JsonProperty(PropertyName = "imageInsightsToken")]
        public string ImageInsightsToken { get; private set; }

        /// <summary>
        /// The URL of the input image. The URL should 
        /// match the image specified by the imageInsightsToken fields if 
        /// both are present. The image binary and URL fields are mutually 
        /// exclusive � do not specify both.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        /// <summary>
        /// A JSON object consisting of coordinates 
        /// specifying the four corners of a cropped rectangle within the 
        /// input image.
        /// </summary>
        [JsonProperty(PropertyName = "cropArea")]
        public CropArea CropArea { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CropArea != null)
            {
                CropArea.Validate();
            }
        }
    }
}
