using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ArraySort;
using WebApplication1.Models;
using WebApplication1.Services;
using WebApplication1.View;

namespace WebApplication1
{
    public class Arrays : IArray
    {
        public List<ArrayPosition> GetArrayPosition()
        {
            List<ArrayPosition> empList;
            try
            {
                empList = _context.Set<ArrayPosition>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return empList;
        }

        public List<SortedArray> GetSortedArray()
        {
            List<SortedArray> empList;
            try
            {
                empList = _context.Set<SortedArray>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return empList;
        }

        public ResponseModel SaveArray(SortedArray sortedarray)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                _context.Add<SortedArray>(sortedarray);
                model.Messsage = "Employee Inserted Successfully";

                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        private ArrayContext _context;
        public Arrays(ArrayContext context)
        {
            _context = context;
        }
    }
}
