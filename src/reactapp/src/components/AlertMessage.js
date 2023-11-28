import React from 'react';
import { Alert, AlertDescription } from "@chakra-ui/react";

const defaultErrorMessage = 'Something went wrong. Please try again later.';

/**
 * 
 * @param
 * message: a single message or a list of message to be added as a list.
 * status?: "error" | "warning" | "info" | "success";
 * @returns an alert component
 */
const AlertMessage = ({ message, status = 'error' }) => {
  // message can be string | string[]
  let content;
  if (Array.isArray(message)) {
    // If message is an array of strings, map over the array to create list items
    const listItems = message.map((item, index) => <li>{item}</li>);
    content = <ul>{listItems}</ul>;
  } else {
    // If message is a string, display it as is
    content = message;
  }
  return (
    <Alert status={status} borderRadius="md">
      <AlertDescription m={ 4 }>{content}</AlertDescription>
    </Alert>
  );
};

export { defaultErrorMessage, AlertMessage };