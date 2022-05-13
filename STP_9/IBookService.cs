using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace STP_9
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookService" in both code and config file together.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        [
          WebGet(
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Wrapped,
          UriTemplate = "/GetBooks"
         )
      ]
        List<Book> GetBooksList();

        [OperationContract]
        [
          WebGet(
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Wrapped,
          UriTemplate = "/GetBooks/{id}"
         )
      ]
        Book GetBookById(string id);
    }
}
