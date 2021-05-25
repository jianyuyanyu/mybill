﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using billservice.models;
using billservice.models.Dto;

// billservice.services

namespace billservice.interfaces
{
    public interface IBill
    {

        bool IsExistId ( int id , string mobile );
        Task<bool> IsExistIdAsync ( int id , string mobile );

        bool Save ( bills bill );
        Task<bool> SaveAsync ( bills bill );

        bool Update ( bills bill );
        Task<bool> UpdateAsync ( bills bill );


        Task<List<BillReturnDto>> GetListAsync ( string mobile , int year , int month , int billtypeid );


        Task<BillReturnDto> GetAsync ( int id );

        Task<bool> DeleteAsync ( int id );


        Task<List<BillMapReturnDto>> GetStatListAsync ( string mobile , int year , int month , bool isout );


        Task<List<BillReturnDto>> GetTopOutListAsync ( string mobile , int year , int month , int topnum );

        Task<List<BillReturnDto>> GetOutListAsync ( string mobile , int year , int month , string mode );

        Task<int> GetOutListCountAsync ( string mobile , int year , int month );
    }
}
