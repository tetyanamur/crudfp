using Microsoft.AspNetCore.Mvc;

namespace testt.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateRepository repo;

        public StateController(IStateRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var states = repo.GetAllStates();

            return View(states);
        }
        public IActionResult ViewState(int id)
        {
            var state = repo.GetState(id);

            return View(state);
        }
        public IActionResult UpdateState(int id)
        {
            State terr = repo.GetState(id);

            if (terr == null)
            {
                return View("StateNotFound");
            }

            return View(terr);
        }
        public IActionResult UpdateStateToDatabase(State state)
        {
            repo.UpdateState(state);

            return RedirectToAction("ViewState", new { id = state.id });
        }
        public IActionResult InsertState()
        {
            var terr = repo.AssignCategory();

            return View(terr);
        }

        public IActionResult InsertStateToDatabase(State stateToInsert)
        {
            repo.InsertState(stateToInsert);

            return RedirectToAction("Index");

        }
        public IActionResult DeleteState(State state)
        {
            repo.DeleteProduct(state);

            return RedirectToAction("Index");
        }

    }
}
