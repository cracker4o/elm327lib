elm327lib
=========

[![Build Status](https://travis-ci.org/cracker4o/elm327lib.svg?branch=master)](https://travis-ci.org/cracker4o/elm327lib)

A C# library for communication with ELM327 devices and OBD II protocols.
The purpose of the project is to provide a library for communication with car diagnostic tools (e.g. Elm327) and OBD2 compliant vehicles.

## License
The elm327lib project is licensed under the Apache License, Version 2.0
You may obtain a copy of the License [here](http://www.apache.org/licenses/LICENSE-2.0)

## Project structure
The project is divided in two parts, commands and responses.
All commands derive from the SendMessage base class and all responses derive 
from the ResponseMessage. The commands and responses are split into logical categories,
ELM and OBDII. All ELM commands/responses are intended for the ELM device and the OBDII
ones are intended for direct communication with the vehicle computer using the ELM327 pass
through mode.


