﻿using AisParser;
using Shouldly;
using Xunit;

namespace AisParserTests
{
    public class ParserTests
    {
        
        [Fact]
        public void Should_return_null_for_message_with_empty_payload1()
        {
            const string sentence = "!AIVDM,1,1,,B,,0*25";

            var decoder = new PayloadDecoder();
            var messageFactory = new AisMessageFactory();
            var parser = new Parser(decoder, messageFactory);

            var result = parser.Parse(sentence);
            result.ShouldBeNull();
        }

        [Fact]
        public void Should_return_null_for_message_with_empty_payload2()
        {
            const string sentence = "!AIVDM,1,1,,A,,0*26";

            var decoder = new PayloadDecoder();
            var messageFactory = new AisMessageFactory();
            var parser = new Parser(decoder, messageFactory);

            var result = parser.Parse(sentence);
            result.ShouldBeNull();
        }
    }
}