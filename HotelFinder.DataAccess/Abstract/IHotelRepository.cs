﻿using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelById(int id);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(HotelDbContext hotel);
        void DeleteHotel(int id);
        Hotel UpdateHotel(Hotel hotel);
    }
}
