# Load testing learning hour

## Connect:
Determine the relationship between these two sets, each element on the left goes with one element on the right:
|-------------|----------------------------------------------------------|
| concurrency | the time to hold target concurrency                      |
| ramp-up     | the number of target concurrent virtual users            |
| hold-for    | limit scenario iterations number                         |
| iterations  | the name of scenario that is described in scenarios part |
| scenario    | the time to reach target concurrency                     |

## Concepts:
Explain:
- [Taurus Blazemeter JMeter executor](https://gettaurus.org/docs/JMeter/)
- [Extractors](https://gettaurus.org/docs/JMeter/#Extractors)
- [Data sources](https://gettaurus.org/docs/DataSources/)
- 

## Practice:
In our website we have two types of users. 
The first set of users, are what we call the searchers. Those people reach our website via the home page and do 4 or 5 searches. Looks like they are not finding what they are looking for, as then they leave the website.
Our second set of users are the bookers. They do succeed at finding what they want. They enter the website via the home page as well and , surprisingly they only need to search twice before finding what they want. Once they have it, they just book it.

WE have almost no traffic, but we plan to launch a marketing campaign pretty soon and we expect it to increase the amount of people visiting our website. Our wildest dreams, suggest we can expect to we have 40 users at the same time on the website, 10 bookers and 30 searchers.

Can you load test our website and let us know if we will be able to support that load gracefully?

To run the test:
`docker run -it --rm -v {current-folder}:/bzt-configs -v {current-folder}:/tmp/artifacts blazemeter/taurus load-test-sample.yml`

## Conclusions
Sit with someone from another couple/group, and discuss:
- Was it easy to create the test?
- And to read the results?
- Have you found anything interesting? If so, how?
