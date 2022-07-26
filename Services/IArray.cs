using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ArraySort;
using WebApplication1.Models;
using WebApplication1.View;

namespace WebApplication1.Services
{
    interface IArray
    {
        /// <summary>
        /// get list of all numbers
        /// </summary>
        /// <returns></returns>
        List<ArrayPosition> GetArrayPosition();
        /// <summary>
        /// get list of all sorted numbers
        /// </summary>
        /// <returns></returns>
        List<SortedArray> GetSortedArray();


        /// <summary>
        ///  Sort Numbers 
        /// </summary>
        /// <param name="sortedarray"></param>
        /// <returns></returns>
        ResponseModel SaveArray(SortedArray sortedarray);

    }

}
