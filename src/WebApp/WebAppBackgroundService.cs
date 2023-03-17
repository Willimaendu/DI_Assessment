namespace WebApp
{
    public class WebAppBackgroundService : BackgroundService
    {
        private readonly GuidService _guidService;

        public WebAppBackgroundService(GuidService guidService)
        {
            _guidService = guidService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine(_guidService.Id);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
