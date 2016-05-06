using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Shopper.DataServices.Interfaces;
using Shopper.Domain;
using Shopper.WebAPI.Services.Models;

namespace Shopper.WebAPI.Services.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public CustomerController()
        {
        }

        // GET: api/Customer
        public IEnumerable<CustomerListModel> Get()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerListModel>());
            var mapper = config.CreateMapper();

            var customers = _customerService.GetAll();
            var customerListModels = mapper.Map<IEnumerable<Customer>, List<CustomerListModel>>(customers);
            return customerListModels;
        }


        // GET: api/Customer/5
        public IHttpActionResult Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerListModel>());
            var mapper = config.CreateMapper();

            var customer = _customerService.GetById(id);
            var transformedCustomer = mapper.Map<Customer, CustomerListModel>(customer);
            if (transformedCustomer == null)
            {
                return BadRequest("No customer found");
            }
            return Ok(transformedCustomer);
        }


        // POST: api/Customer
        public HttpResponseMessage Post(CustomerListModel customerListModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerListModel, Customer>());
            var mapper = config.CreateMapper();
            var transformedCustomer = mapper.Map<CustomerListModel, Customer>(customerListModel);
            _customerService.Add(transformedCustomer);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            response.StatusCode = HttpStatusCode.Created;
            var uri = Url.Link("DefaultApi", new { id = customerListModel.CustomerId });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT: api/Customer/5
        public HttpResponseMessage Put(int id, CustomerListModel customerListModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerListModel, Customer>());
            var mapper = config.CreateMapper();
            var transformedCustomer = mapper.Map<CustomerListModel, Customer>(customerListModel);
            transformedCustomer.CustomerId = id;
            _customerService.Update(transformedCustomer);
            var response = Request.CreateResponse(HttpStatusCode.NoContent);
            var uri = Url.Link("DefaultApi", new { id = customerListModel.CustomerId });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // DELETE: api/Customer/5
        public HttpResponseMessage Delete(int id)
        {
            var customer = _customerService.GetById(id);
            _customerService.Delete(customer);
            var response = Request.CreateResponse(HttpStatusCode.NoContent);
            return response;
        }
    }
}