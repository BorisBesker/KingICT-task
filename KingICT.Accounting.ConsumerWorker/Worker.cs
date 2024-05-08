namespace KingICT.Accounting.ConsumerWorker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Consumes the messages for particular que, in case some other processing is needed it can also use business logic project from accounting context then call the Microsoft Navision API => act like adapter

            // Gets the (nugget) package from Messages context

            // Here for example only for tickets but assuming accounting will need also data from other contexts (e.g. Sales context) => then it will use nuget => Sales messages

            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
