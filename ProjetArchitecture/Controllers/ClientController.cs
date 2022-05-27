using Microsoft.AspNetCore.Mvc;
using ProjetArchitecture.Interface;
using ProjetArchitecture.Models.BankModels;
using ProjetArchitecture.Models.ViewModes;

namespace ProjetArchitecture.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        public IActionResult Index(ClientViewModel clientModel)


        {

            var dateParsedStart = new DateTime();
            var dateParsedEnd = new DateTime();
            if (!string.IsNullOrEmpty(clientModel.DateFirst))
            {
                var datetimeStart = DateTime.Parse(clientModel.DateFirst);

                dateParsedStart = new DateTime(datetimeStart.Year, datetimeStart.Month, datetimeStart.Day, 0, 0, 0);
                if (!string.IsNullOrEmpty(clientModel.DateSecond))
                {
                    var datetimeEnd = DateTime.Parse(clientModel.DateSecond);
                    dateParsedEnd = new DateTime(datetimeEnd.Year, datetimeEnd.Month, datetimeEnd.Day, 23, 59, 59);
                }
                else
                {
                    dateParsedEnd = new DateTime(datetimeStart.Year, datetimeStart.Month, datetimeStart.Day, 23, 59, 59);
                }
            }
            else
            {
                dateParsedEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 25, 23, 59, 59);
                var datetimeStart = dateParsedEnd.AddMonths(-1);
                dateParsedStart = new DateTime(datetimeStart.Year, datetimeStart.Month, 26, 0, 0, 0);

            }

            //var Clients = _clientService.GetAllClient().Where(x => x.DateJoined <= dateParsedStart && x.DateJoined >= dateParsedEnd).ToList();
            
            var Clients = _clientService.GetAllClient().ToList();

            if (clientModel.Client != null && clientModel.Client != "Tous")
            {
                Clients = Clients.Where(x => x.IdClient.ToString() == clientModel.Client).ToList();
            }

            if (clientModel.NumCin != null)
            {
                Clients = Clients.Where(x => x.NumCIN == clientModel.NumCin).ToList();
            }

            if (clientModel.ClientType != null)
            {
                Clients = Clients.Where(x => x.ClientType == clientModel.ClientType).ToList();
            }

            if (TempData["Message"] != null)
            {
                ViewBag.DspMessage = TempData["Message"].ToString();
            }
            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"].ToString();
            }
            clientModel.ListClients = Clients;
            return View(clientModel);
        }

        public IActionResult Create()
        {

            return View();
        }

        public IActionResult CreateClient(Client client)
        {
            try
            {

                var msg = _clientService.CreateClient(client);
                if (msg == "Done")
                {
                    TempData["Message"] = "Client enregistré avec Succées";
                }
                else
                {
                    TempData["ErrorMessage"] = "Erreur d'enregistrement";
                }

            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Edit(int idClient)
        {

            var client = _clientService.GetClientById(idClient);

            return View(client);
        }

        public IActionResult EditClient(Client client)
        {
            try
            {

                var msg = _clientService.EditClient(client);
                if (msg == "Done")
                {
                    TempData["Message"] = "Client modifié avec Succé";
                }
                else
                {
                    TempData["ErrorMessage"] = "Erreur de modification";
                }

            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteClient(int idClient)
        {
            var msg = _clientService.DeleteClient(idClient);
            if (msg == "Done")
            {
                TempData["Message"] = "Client Supprimé avec Succée";
            }
            else
            {
                TempData["ErrorMessage"] = "Erreur de suppression";
            }

            return RedirectToAction("Index");
        }

        public IActionResult Details(int idClient)
        {
            var client = _clientService.GetClientById(idClient);

            return View(client);
        }
    }
}
