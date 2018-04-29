using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Sandbox.Models
{
    class RoomModel
    {
        public string roomID { get; set; }
        public string tags { get; set; }
        public string shortInfo { get; set; }
        public string userID { get; set; }
        public string ownerID { get; set; }
        public List<ObjectModel> objectsInRoom { get; set; }

        public RoomModel(){

            roomID = "shit";
            tags = "shit";
            shortInfo = "shit";
            userID = "shit";
            ownerID = "shit";
            objectsInRoom = new List<ObjectModel>();
            
        }

}
    class ObjectModel
    {
        public string objectId { get; set; }
        public string objectName { get; set; }
        public string shortInfo { get; set; }

        public ObjectModel()
        {
            objectId = "objectshit";
            objectName = "objectshit";
            shortInfo = "objectshit";
        }
}
}