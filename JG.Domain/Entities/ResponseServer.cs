namespace JG.Domain.Entities
{
    public class ResponseServer<Entity>
    {
        public Entity Result { get; set; }
        public Error Error { get; set; }

        public static ResponseServer<Entity> GetResponse(Entity value, Error error)
        {
            ResponseServer<Entity> reponse = new ResponseServer<Entity>();

            reponse.Result = value;
            reponse.Error = error;

            return reponse;
        }
    }

    public class Error
    {
        public string Message { get; set; }

    }
}
