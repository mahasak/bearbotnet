# BearBot

Demonstrationon how to use Metrics.Net with InfluxDb and Grafana to visualize ASP.Net MVC Web Application for scalable application
## configuration
- Web.Config
  - AppSettings
    - botInterval => int ; Number of seconds bot should run the test

## Urls
- http://localhost:1234 => local metrics monitor for debugging purpose e.g. inspect number of test running and pass/fail
- http://localhost[:port]/Dashbord => Dashboard

## Todo
- Implement Scenario Repository
- Implement Metrics Reporter
- Implement Operation Dashboard (Grafana)
- Implement Customer Dashnoard with History