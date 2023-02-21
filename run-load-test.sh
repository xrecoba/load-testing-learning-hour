docker run -it --rm --network host -v $(pwd):/bzt-configs -v $(pwd)\taurus-artifacts:/tmp/artifacts blazemeter/taurus load-test-kata.yml

docker run -it --rm --network host -v $(pwd):/bzt-configs blazemeter/taurus load-test-sample.yml

docker run --rm --network host -v $(pwd):/bzt-configs blazemeter/taurus load-test-sample.yml

docker run --rm --network host -v c/Users/xavi.ametller/personal/load-testing-learning-hour:/bzt-configs blazemeter/taurus load-test-sample.yml

docker run --rm --network host -v c/Users/xavi.ametller/personal/load-testing-learning-hour:/bzt-configs blazemeter/taurus dp-load-test-read.yml

