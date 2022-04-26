using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VigEncoder.Tests
{
    [TestClass]
    public class VigEncoderTests
    {
        [TestMethod]
        public void Decode_text_ААББаабб_Key_абвг_result_АЯЯЮаяяю()
        {
            string text = "ААББаабб";
            string key = "абвг";
            string expected = "АЯЯЮаяяю";
            string result = VigenerCode.Decode(text, key);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Decode_text_тоьлтпдуц_Key_аюскца_result_тркбьпдхе()
        {
            string text = "тоьлтпдуц";
            string key = "аюскца";
            string expected = "тркбьпдхе";
            string result = VigenerCode.Decode(text, key);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Encode_text_фитеькущш_Key_йц_result_юяьыёбэпв()
        {
            string text = "фитеькущш";
            string key = "йц";
            string expected = "юяьыёбэпв";
            string result = VigenerCode.Encode(text, key);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Encode_text_яяюяяюяюьъьъхчсю_Key_яаъюяь_result_юяшэюъююцшыцфчль()
        {
            string text = "яяюяяюяюьъьъхчсю";
            string key = "яаъюяь";
            string expected = "юяшэюъююцшыцфчль";
            string result = VigenerCode.Encode(text, key);
            Assert.AreEqual(expected, result);
        }
    }
}
