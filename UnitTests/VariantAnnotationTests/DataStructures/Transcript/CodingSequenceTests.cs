﻿using UnitTests.Utilities;
using Xunit;

namespace UnitTests.VariantAnnotationTests.DataStructures.Transcript
{
    public class CodingSequenceTests
    {
        [Trait("transcript", "ENST00000257290,ENST00000480326,ENST00000355439,ENST00000474953")]
        [Theory]
        [InlineData("4", "ENST00000257290_chr4_Ensembl84", "ATGGGGACTTCCCATCCGGCGTTCCTGGTCTTAGGCTGTCTTCTCACAGGGCTGAGCCTAATCCTCTGCCAGCTTTCATTACCCTCTATCCTTCCAAATGAAAATGAAAAGGTTGTGCAGCTGAATTCATCCTTTTCTCTGAGATGCTTTGGGGAGAGTGAAGTGAGCTGGCAGTACCCCATGTCTGAAGAAGAGAGCTCCGATGTGGAAATCAGAAATGAAGAAAACAACAGCGGCCTTTTTGTGACGGTCTTGGAAGTGAGCAGTGCCTCGGCGGCCCACACAGGGTTGTACACTTGCTATTACAACCACACTCAGACAGAAGAGAATGAGCTTGAAGGCAGGCACATTTACATCTATGTGCCAGACCCAGATGTAGCCTTTGTACCTCTAGGAATGACGGATTATTTAGTCATCGTGGAGGATGATGATTCTGCCATTATACCTTGTCGCACAACTGATCCCGAGACTCCTGTAACCTTACACAACAGTGAGGGGGTGGTACCTGCCTCCTACGACAGCAGACAGGGCTTTAATGGGACCTTCACTGTAGGGCCCTATATCTGTGAGGCCACCGTCAAAGGAAAGAAGTTCCAGACCATCCCATTTAATGTTTATGCTTTAAAAGCAACATCAGAGCTGGATCTAGAAATGGAAGCTCTTAAAACCGTGTATAAGTCAGGGGAAACGATTGTGGTCACCTGTGCTGTTTTTAACAATGAGGTGGTTGACCTTCAATGGACTTACCCTGGAGAAGTGAAAGGCAAAGGCATCACAATGCTGGAAGAAATCAAAGTCCCATCCATCAAATTGGTGTACACTTTGACGGTCCCCGAGGCCACGGTGAAAGACAGTGGAGATTACGAATGTGCTGCCCGCCAGGCTACCAGGGAGGTCAAAGAAATGAAGAAAGTCACTATTTCTGTCCATGAGAAAGGTTTCATTGAAATCAAACCCACCTTCAGCCAGTTGGAAGCTGTCAACCTGCATGAAGTCAAACATTTTGTTGTAGAGGTGCGGGCCTACCCACCTCCCAGGATATCCTGGCTGAAAAACAATCTGACTCTGATTGAAAATCTCACTGAGATCACCACTGATGTGGAAAAGATTCAGGAAATAAGGTATCGAAGCAAATTAAAGCTGATCCGTGCTAAGGAAGAAGACAGTGGCCATTATACTATTGTAGCTCAAAATGAAGATGCTGTGAAGAGCTATACTTTTGAACTGTTAACTCAAGTTCCTTCATCCATTCTGGACTTGGTCGATGATCACCATGGCTCAACTGGGGGACAGACGGTGAGGTGCACAGCTGAAGGCACGCCGCTTCCTGATATTGAGTGGATGATATGCAAAGATATTAAGAAATGTAATAATGAAACTTCCTGGACTATTTTGGCCAACAATGTCTCAAACATCATCACGGAGATCCACTCCCGAGACAGGAGTACCGTGGAGGGCCGTGTGACTTTCGCCAAAGTGGAGGAGACCATCGCCGTGCGATGCCTGGCTAAGAATCTCCTTGGAGCTGAGAACCGAGAGCTGAAGCTGGTGGCTCCCACCCTGCGTTCTGAACTCACGGTGGCTGCTGCAGTCCTGGTGCTGTTGGTGATTGTGATCATCTCACTTATTGTCCTGGTTGTCATTTGGAAACAGAAACCGAGGTATGAAATTCGCTGGAGGGTCATTGAATCAATCAGCCCAGATGGACATGAATATATTTATGTGGACCCGATGCAGCTGCCTTATGACTCAAGATGGGAGTTTCCAAGAGATGGACTAGTGCTTGGTCGGGTCTTGGGGTCTGGAGCGTTTGGGAAGGTGGTTGAAGGAACAGCCTATGGATTAAGCCGGTCCCAACCTGTCATGAAAGTTGCAGTGAAGATGCTAAAACCCACGGCCAGATCCAGTGAAAAACAAGCTCTCATGTCTGAACTGAAGATAATGACTCACCTGGGGCCACATTTGAACATTGTAAACTTGCTGGGAGCCTGCACCAAGTCAGGCCCCATTTACATCATCACAGAGTATTGCTTCTATGGAGATTTGGTCAACTATTTGCATAAGAATAGGGATAGCTTCCTGAGCCACCACCCAGAGAAGCCAAAGAAAGAGCTGGATATCTTTGGATTGAACCCTGCTGATGAAAGCACACGGAGCTATGTTATTTTATCTTTTGAAAACAATGGTGACTACATGGACATGAAGCAGGCTGATACTACACAGTATGTCCCCATGCTAGAAAGGAAAGAGGTTTCTAAATATTCCGACATCCAGAGATCACTCTATGATCGTCCAGCCTCATATAAGAAGAAATCTATGTTAGACTCAGAAGTCAAAAACCTCCTTTCAGATGATAACTCAGAAGGCCTTACTTTATTGGATTTGTTGAGCTTCACCTATCAAGTTGCCCGAGGAATGGAGTTTTTGGCTTCAAAAAATTGTGTCCACCGTGATCTGGCTGCTCGCAACGTCCTCCTGGCACAAGGAAAAATTGTGAAGATCTGTGACTTTGGCCTGGCCAGAGACATCATGCATGATTCGAACTATGTGTCGAAAGGCAGTACCTTTCTGCCCGTGAAGTGGATGGCTCCTGAGAGCATCTTTGACAACCTCTACACCACACTGAGTGATGTCTGGTCTTATGGCATTCTGCTCTGGGAGATCTTTTCCCTTGGTGGCACCCCTTACCCCGGCATGATGGTGGATTCTACTTTCTACAATAAGATCAAGAGTGGGTACCGGATGGCCAAGCCTGACCACGCTACCAGTGAAGTCTACGAGATCATGGTGAAATGCTGGAACAGTGAGCCGGAGAAGAGACCCTCCTTTTACCACCTGAGTGAGATTGTGGAGAATCTGCTGCCTGGACAATATAAAAAGAGTTATGAAAAAATTCACCTGGACTTCCTGAAGAGTGACCATCCTGCTGTGGCACGCATGCGTGTGGACTCAGACAATGCATACATTGGTGTCACCTACAAAAACGAGGAAGACAAGCTGAAGGACTGGGAGGGTGGTCTGGATGAGCAGAGACTGAGCGCTGACAGTGGCTACATCATTCCTCTGCCTGACATTGACCCTGTCCCTGAGGAGGAGGACCTGGGCAAGAGGAACAGACACAGCTCGCAGACCTCTGAAGAGAGTGCCATTGAGACGGGTTCCAGCAGTTCCACCTTCATCAAGAGAGAGGACGAGACCATTGAAGACATCGACATGATGGATGACATCGGCATAGACTCTTCAGACCTGGTGGAAGACAGCTTCCTGTAA")]
        [InlineData("1", "ENST00000480326_chr1_Ensembl84", "NGGACCCAAGAGAGCCTAGCAGAGAAGGAGCTCCAGCTTCTGGTCATGATTCACCAGCTGTCCACCCTGCGGGACCAGCTCCTGACAGCCCACTCGGAGCAGAAGAACATGGCTGCCATGCTGTTTGAGAAGCAGCAGCAGCAGATGGAGCTTGCCCGGCAGCAGCAGGAGCAGATTGCAAAGCAGCAGCAGCAGCTGATTCAGCAGCAGCATAAGATCAACCTCCTTCAGCAGCAGATCCAGCAGGTTAACATGCCTTATGTCATGATCCCAGCCTTCCCCCCAAGCCACCAACCTCTGCCTGTCACCCCTGACTCCCAGCTGGCCTTACCCATTCAGCCCATTCCCTGCAAACCAGGACTTTTCTCCTTGCTGCCTTTTCCATAG")]
        [InlineData("1", "ENST00000355439_chr1_Ensembl84", "ATGTCGTCCTCGGTGAAAACCCCAGCACTGGAAGAGCTGGTTCCTGGCTCCGAAGAGAAGCCGAAAGGCAGGTCGCCTCTCAGCTGGGGCTCTCTGTTTGGTCACCGAAGTGAGAAGATTGTTTTTGCCAAGAGCGACGGCGGCACAGATGAGAACGTACTGACCGTCACCATCACGGAGACCACGGTCATCGAGTCAGACTTGGGTGTGTGGAGCTCGCGGGCGCTGCTCTACCTCACGCTGTGGTTCTTCTTCAGCTTCTGCACGCTCTTCCTCAACAAGTACATCCTGTCCCTGCTGGGAGGCGAGCCCAGCATGCTAGGTGCGGTGCAGATGCTGTCCACCACGGTTATCGGGTGTGTGAAAACCCTCGTTCCTTGCTGTTTATATCAGCACAAGGCCCGGCTTTCCTACCCACCCAACTTCCTTATGACGATGCTGTTTGTGGGTCTGATGAGGTTTGCAACTGTGGTTTTGGGTTTGGTCAGCCTGAAAAATGTGGCGGTTTCGTTTGCTGAGACGGTGAAGAGCTCCGCCCCCATCTTCACGGTGATCATGTCTCGGATGATTCTGGGGGAGTACACAGGACGTCCCAGTGATCGGGAGGAGCGGGAAGAGCTTCAGCTACAACCAGGACGTGGTGCTGCTGCTTCTGACAGACGGAGTCCTGTTCCACCTTCAGAGCGTCACGGCGTACGCCCTCATGGGGAAAATCTCCCCGGTGACTTTCAGGCCCAGTAA")]
        [InlineData("1", "ENST00000474953_chr1_Ensembl84", "NNCAAAAACTCTGATACTGCTCATATTAAGTCCATAGAAATTACTTCGATCCTTAATGGACTTCAAGCTTCTGAAAGTTCTGCTGAAGACAGTGAGCAGGAAGATGAGAGAGGTGCTCAAGACATGGATAATAATGGCAAAGAGGAATCTAAGATTGATCATTTGACCAACAACAGAAATGATCTTATTTCAAAGGAGGAACAGAACAGTTCATCTTTGCTAGAAGAAAACAAAGTTCATGCAGATTTGGTAATATCCAAACCAGTGTCAAAATCTCCAGAAAGATTAAGGAAAGATATAGAAGTATTATCCGAAGATACTGATTATGAAGAAGATGAAGTCACAAAAAAGAGAAAGGATGTCAAGAAGGACACAACAGATAAATCTTCAAAACCACAAATAAAACGTGGTAAAAGAAGGTATTGCAATACAGAAGAGTGTCTAAAAACTGGATCACCTGGCAAAAAGGAAGAGAAGGCCAAGAACAAAGAATCACTTTGCATGGAAAACAGTAGCAACAGCTCTTCAGATGAAGATGAAGAAGAAACAAAAGCAAAGATGACACCAACTAAGAAATACAATGGTTTGGAGGAAAAAAGAAAATCTCTACGGACAACTGGTTTCTATTCAGGATTTTCAGAAGTGGCAGAAAAAAGGATTAAACTTTTAAATAACTCTGATGAAAGACTTCAAAACAGCAGGGCCAAAGATCGAAAAGATGTCTGGTCAAGTATTCAGGGACAGTGGCCTAAAAAAACGCTGAAAGAGCTTTTTTCAGACTCTGATACTGAGGCTGCAGCTTCCCCACCGCATCCTGCCCCAGAGGAGGGGGTGGCAGAGGAGTCACTGCAGACTGTGGCTGAAGAGGAGAGTTGTTCACCCAGTGTAGAACTAGAAAAACCACCTCCAGTCAATGTCGATAGTAAACCCATTGAAGAAAAAACAGTAGAGGTCAATGACAGAAAAGCAGAATTTCCAAGTAGTGGCAGTAATTCAGTGCTAAATACCCCTCCTACTACACCTGAATCGCCTTCATCAGTCACTGTAACAGAAGGCAGCCGGCAGCAGTCTTCTGTAACAGTATCAGAACCACTGGCTCCAAACCAAGAAGAGGTTCGAAGTATCAAGAGTGAAACTGATAGCACAATTGAGGTGGATAGTGTTGCTGGGGAGCTCCAAGACCTCCAGTCTGAAGGGAATAGCTCGCCAGCAGGTTTTGATGCCAGTGTGAGCTCAAGCAGTAGTAATCAGCCAGAACCAGAACATCCTGAAAAAGCCTGTACAGGTCAGAAAAGAGTGAAAGATGCTCAGGGAGGAGGAAGTTCATCAAAAAAGCAGAAAAGAAGCCATAAAGCAACAGTGGTAAACAACAAAAAGAAGGGAAAAGGCACAAATAGTAGTGATAGTGAAGAACTTTCAGCTGGTGAAAGTATAACTAAGAGTCAGCCAGTCAAATCAGTTTCCACTGGAATGAAGTCTCATAGTACCAAATCTCCCGCAAGGACGCAGTCTCCAGGAAAATGTGGAAAGAATGGTGATAAGGATCCTGATCTCAAGGAACCCAGTAATCGATTACCCAAAGTTTACAAATGGAGTTTTCAGATGTCGGACCTGGAAAATATGACAAGTGCCGAACGCATCACAATTCTTCAAGAAAAACTTCAAGAAATCAGAAAACATTATCTGTCATTAAAATCTGAAGTAGCTTCCATTGATCGGAGGAGAAAGCGTTTAAAGAAGAAAGAGAGAGAAAGTGCTGCTACATCCTCATCCTCCTCTTCACCTTCATCCAGTTCCATAACAGCTGCTGTTATGTTAACTTTAGCTGAACCGTCAATGTCCAGCGCATCACAAAATGGAATGCTTCAACCACTCCCAGAAGACGTCCTTCACTCCCAAAATGAGGCTTTTCTGAAACGGCGAGGACCACCAACCGACGGCGACAAACCTGCTCCCTCACCCAGCGCCTCCCTTCGCCGCCGCCCGGCGGCCGACTGCCGGAGGGGAGGGGGCGTGGCCAGAGAGCGGAAGTGCCCGGAACCCGGAAGTGCGAGCTGGCGCGCAGCTGCAGTCTGGGAGTCTTTGGAGTAA")]
        public void Check(string ensemblRefName, string cacheStub, string expectedSequence)
        {
            var cachePath          = Resources.CacheGRCh37(cacheStub);
            var cache              = DataUtilities.GetTranscriptCache(cachePath);
            var compressedSequence = DataUtilities.GetCompressedSequence(cachePath, ensemblRefName);
            var cacheData = new CacheData(compressedSequence, cache.Transcripts[0]);

            var translateableSequence = cacheData.GetCodingSequence();
            var observedSequence = translateableSequence.Sequence();
            Assert.Equal(expectedSequence, observedSequence);
        }
    }
}
