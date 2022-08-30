using System.Collections.Generic;
using testt.Models;


namespace testt
{
    public interface IStateRepository
    {
        public IEnumerable<State> GetAllStates();
        public State GetState(int id);
        public void UpdateState(State state);
        public void InsertState(State stateToInsert);
        public IEnumerable<Category> GetCategories();
        public State AssignCategory();
        public void DeleteProduct(State state);
    }
}
