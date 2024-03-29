﻿using BookStore_DL.Interfaces;

namespace BookStore_BL.Services
{
    internal class ILibraryService : ILibraryRepository
    {
        private readonly ILibraryService _libraryService;

        public ILibraryService(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        public string GetLibraryName()
        {
            throw new NotImplementedException();
        }
    }
}