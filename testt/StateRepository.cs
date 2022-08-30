using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using testt.Models;

namespace testt
{
    public class StateRepository : IStateRepository
    {
        private readonly IDbConnection _conn;
        public StateRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public State AssignCategory()
        {
            var categoryList = GetCategories();
            var state = new State();

            return state;
        }

        public void DeleteProduct(State state)
        {
            _conn.Execute("DELETE FROM REVIEWS WHERE id = @id;",
                                       new { id = state.id });
            _conn.Execute("DELETE FROM Sales WHERE id = @id;",
                                       new { id = state.id });
            _conn.Execute("DELETE FROM Products WHERE id = @id;",
                                       new { id = state.id });
        }

        public IEnumerable<State> GetAllStates()
        {
            return _conn.Query<State>("SELECT * FROM state;");
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM state;");
        }

        public State GetState(int id)
        {
            return _conn.QuerySingle<State>("SELECT * FROM state WHERE id = @id",
              new { id = id });
        }

        public void InsertState(State stateToInsert)
        {
            _conn.Execute("INSERT INTO products (name, code, region) VALUES (@name, @code, @region);",
                new { name = stateToInsert.name, code = stateToInsert.code, region = stateToInsert.id });
        }

        public void UpdateState(State state)
        {
            _conn.Execute("UPDATE state SET Name = @name, code = @code WHERE id = @id",
                new { name = state.name, code = state.code, id = state.id });
        }
    }
}
