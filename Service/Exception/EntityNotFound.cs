namespace C_Sharp_Board.Service.Exception
{
    public class EntityNotFound : SystemException
    {
        public EntityNotFound(string msg) : base(msg)
        {

        }
    }
}