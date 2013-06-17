using System.Data;

namespace Clb.Dal
{
    public class InitializeCommand
    {
        private Crud _crud;

        public InitializeCommand(Crud crud)
        {
            _crud = crud;
        }

        public void Command()
        {
            _crud.Cmd.Connection = _crud.Conn;
            _crud.Cmd.CommandType = CommandType.StoredProcedure;
            _crud.Cmd.CommandText = _crud.StoredProcedureProperty;
        }
    }
}