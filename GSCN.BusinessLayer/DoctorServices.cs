using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GSCN.DataLayer;
using GSCN.Dto;
using GSCN.Models;
using Microsoft.EntityFrameworkCore;

namespace GSCN.BusinessLayer
{
    public class AppMapper : Profile
    {
        public AppMapper()
        {
            CreateMap<BankInfo, DtoBankInfo>().ReverseMap();
            CreateMap<FeesAndTiming, DtoFeesAndTiming>().ReverseMap();
            CreateMap<Doctor, DtoDoctor>().ReverseMap();
            CreateMap<EducationalDetails, DtoEducationalDetails>().ReverseMap();
            CreateMap<ContactDetails, DtoContactDetails>().ReverseMap();
            CreateMap<Experience, DtoExperience>().ReverseMap();
        }
    }

    public class DoctorServices
    {
        private readonly IMapper Mapper;
        private readonly GSCNContext GSCNContext;

        public DoctorServices(IMapper _mapper, GSCNContext _context)
        {
            Mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));

            GSCNContext = _context ?? throw new ArgumentNullException(nameof(_context));
        }

        /// <summary>
        /// Add the doctor
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns></returns>
        public async Task<bool> AddDoctor(DtoDoctor doctor)
        {
            return true;
        }

        /// <summary>
        /// Get all the doctors
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoDoctor>> GetDoctors()
        {
            try
            {
                var listDoctors = GSCNContext.Doctors;
                var resultDoctors = Mapper.Map<List<DtoDoctor>>(listDoctors);
                return resultDoctors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get DoctoBy Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DtoDoctor> GetDoctorById(int id)
        {
            try
            {
                var doctor = await GSCNContext.Doctors.Where(x => x.DoctorId == id).FirstOrDefaultAsync();
                var result = Mapper.Map<DtoDoctor>(doctor);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update the doctor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DtoDoctor> UpdateDoctor(DtoDoctor doctor)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete doctor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteDoctor(int id)
        {
            try
            {
                return 1;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
