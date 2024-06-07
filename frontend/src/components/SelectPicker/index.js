import { useEffect, useState } from "react";
import { Dimensions, StyleSheet, Text, View } from "react-native";
import ScrollPicker from "./ScrollPicker";
import { colors } from "../../colors.config";

export const SelectPicker = ({onItemPress, valueNow, list}) => {

  return (
    <ScrollPicker
        list={list}
        onItemPress={onItemPress}
        labelColor="white"
        separatorColor="white"
        selectedColor= {colors.orange}
        currentValue={valueNow}
    />
  );
};

