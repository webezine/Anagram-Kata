using AnagramConsole.Common.Interfaces;

namespace AnagramConsole.DAL.Queries
{
    public abstract class BaseQuery
    {
        protected readonly IDapperWrapperFactory ConnectionFactory;
        
        protected BaseQuery(IDapperWrapperFactory connectionFactory)
        {
            ConnectionFactory = connectionFactory;
        }

    }
}
