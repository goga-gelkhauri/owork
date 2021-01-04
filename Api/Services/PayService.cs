using Api.Dto;
using AutoMapper;
using Core.Entities;
using Infrastructure.Data;
using System.Threading.Tasks;

namespace Api.Services
{
    public class PayService
    {
        private readonly PayRepository _payRepository;
        private readonly EfRepository<Charity> _charityRepository;
        private readonly EfRepository<Communal> _communalRepository;
        private readonly EfRepository<Finance> _financeRepository;
        private readonly IMapper _mapper;

        public PayService(PayRepository payRepository,
        EfRepository<Charity> charityRepository,
        EfRepository<Communal> communalRepository,
        EfRepository<Finance> financeRepository,
        IMapper mapper)
        {
            _payRepository = payRepository;
            _mapper = mapper;
            _charityRepository = charityRepository;
            _communalRepository = communalRepository;
            _financeRepository = financeRepository;
        }

        public async Task AddMobile(MobileDto mobileDto)
        {
            mobileDto.Commission = CalculateCommission(mobileDto.Amount);
            mobileDto.Service = "mobile";
            var mobile = _mapper.Map<Mobile>(mobileDto);
            await _payRepository.AddAsync(mobile);
        }

        public async Task AddCharity(CharityDto charityDto)
        {
            charityDto.Commission = CalculateCommission(charityDto.Amount);
            charityDto.Service = "charity";
            var charity = _mapper.Map<Charity>(charityDto);
            await _charityRepository.AddAsync(charity);
        }

        public async Task AddCommunal(CommunalDto communalDto)
        {
            communalDto.Commission = CalculateCommission(communalDto.Amount);
            communalDto.Service = "communal";
            var communal = _mapper.Map<Communal>(communalDto);
            await _communalRepository.AddAsync(communal);
        }

        public async Task AddFinance(FinanceDto financeDto)
        {
            financeDto.Commission = CalculateCommission(financeDto.Amount);
            financeDto.Service = "finance";
            var finance = _mapper.Map<Finance>(financeDto);
            await _financeRepository.AddAsync(finance);
        }



        private float CalculateCommission(float amount)
        {
            return (amount / 100) < 0.5f ? 0.5f : amount / 100;
        }

    }
}