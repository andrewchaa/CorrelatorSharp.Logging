using System;
using Machine.Specifications;
using NLog.Config;

namespace CorrelatorSharp.Logging.Tests
{
    public class ConfigurationSpecs
    {
        public class When_not_configured
        {
            It should_fallback_to_the_dummy_logmanager = () => LogManager.GetCurrentClassLogger().ShouldNotBeNull();
        }

        public class When_get_current_class_logger
        {
            private static ILogger _logger;

            Because of = () => _logger = LogManager.GetCurrentClassLogger(); 

            It should_have_caling_class_name_as_logger = () => _logger.Name.ShouldEqual("CorrelatorSharp.Logging.Tests.ConfigurationSpecs+When_get_current_class_logger+<>c");
        }

    }
}
