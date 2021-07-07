using System; 

namespace ScribbleBoardApi.Models
{
  public class Image
  {
    public int ImageId {get; set;}
    // this needs to be converted between base64 string with Convert.FromBase64String() or Convert.ToBase64String();
    public byte[] Data {get; set;}
    public string Artist {get; set;}
    public int ArtistId {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    public DateTime CreatedAt {get; set;}
  }
}