# ZeroMqWithNgrokDemo

The project has a publisher and a subscriber project. Both projects user ZeroMQ via [NuGet package NetMQ](https://www.nuget.org/packages/NetMQ).

To run everything, do the following.
1. [Install NGrok](https://ngrok.com/)
1. Expose this port `ngrok tcp 5556`
1. Change the url in the subscriber project.
1. Run everything (see GIF below)

![Descriptive alt text](demo.gif)


