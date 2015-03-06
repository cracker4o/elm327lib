elm327lib
=========

[![Build Status](https://travis-ci.org/cracker4o/elm327lib.svg?branch=master)](https://travis-ci.org/cracker4o/elm327lib)

A C# library for communication with ELM327 devices and OBD II protocols.

All commands implement the ISendMessage interface and all responses implement the IReceiveMessage interface. Each command and response has the following properties: Command, Data, StartTermination, EndTermination. The message format for the OBDII protocol is |COMMAND|DATA|ENDTERMINATION . The start termination is not used. The end termination can be configured for <CR><LF> or |CR| only. Spaces are optional. Commands starting with AT are only internal for the ELM327 device. OBD commands can contain only digits from 0-9 and letters from A-F (HEX NUMBERS). All commands are terminated with CR (0x0D). Incomplete messages which are not understood by the ELM327 (syntax errors) will return '?' after 20 seconds. ELM327 is not case sensitive.

